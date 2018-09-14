(function () {
    $(function () {

        var _componentService = abp.services.app.componentInfo;
        var _$modal = $('#RoleCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshRoleList();
        });

        $('.delete-role').click(function () {
            var roleId = $(this).attr("data-role-id");
            var roleName = $(this).attr('data-role-name');

            deleteRole(roleId, roleName);
        });

        $('.edit-role').click(function (e) {
            var roleId = $(this).attr("data-role-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Components/EditComponentModal?cId=' + roleId,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#RoleEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });

        $('.send-component').click(function () {
            var cid = $(this).attr("data-role-id");
            sendFlow(cid);
        });
        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var role = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$modal);
            _componentService.create(role).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new role!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshRoleList() {
            location.reload(true); //reload page to see new role!
        }

        function deleteRole(roleId, roleName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'OneWorkFlow'), roleName),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _componentService.delete({
                            id: roleId
                        }).done(function () {
                            refreshRoleList();
                        });
                    }
                }
            );
        }

        function sendFlow(cid) {
            abp.notify.info('发起流程', '系统提示');
            var newPerson = {
                name: 'Dougles Adams',
                age: 42
            };
            abp.ui.setBusy(null);
            abp.ajax({
                url: '/People/SavePerson',
                data: JSON.stringify(newPerson)
            }).done(function (data) {
                abp.notify.success('流程处理成功！', '系统提示');
            });
            abp.ui.clearBusy(null);
        }

    });
})();