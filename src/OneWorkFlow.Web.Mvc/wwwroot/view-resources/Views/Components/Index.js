import { url } from "inspector";

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

        $('.send-component').click(function (e) {
            //var cid = $(this).attr("data-role-id");
            //e.preventDefault();
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
            //abp.notify.info('发起流程', '系统提示');
            //var newPerson = {
            //    name: 'Dougles Adams',
            //    age: 42
            //};
            //abp.ui.setBusy(null);
            //abp.ajax({
            //    url: '/People/SavePerson',
            //    data: JSON.stringify(newPerson)
            //}).done(function (data) {
            //    abp.notify.success('流程处理成功！', '系统提示');
            //});
            //abp.ui.clearBusy(null);
            //$.ajax({
            //    url: abp.appPath + 'Components/SendWorkFlow?cId=' + cid,
            //    type: 'POST',
            //    contentType: 'application/html',
            //    success: function (content) {
            //        $('#WorkFlowEditModal div.modal-content').html(content);
            //    },
            //    error: function (e) { }
            //});
            var new_window = null;
            //url = "http://localhost:801/OneFlow/FlowExecute?token=" + token + "&rid=" + id + "&flowid=" + flowId + "&flowOpation=" + flowOpation;
            //var url = "http://39.105.138.229:8011/OneFlow/FlowExecute?token=" + token + "&rid=" + id + "&flowid=" + flowId + "&flowOpation=" + flowOpation + "&isSelect=" + isSelect + "";
            var url = "http://39.105.138.229:8011/OneFlow/FlowExecute?token=0e93bb87-9897-41b3-aa96-5918cde5a2cd&rid=1&flowid=5c00761b-309a-4695-8784-95b0c6b1ccd8&flowOpation=0&isSelect=0";
            //var url ="http://localhost:801/OneFlow/FlowExecute?token=ba6d6f4b-4f5b-4eef-801c-1869084bf5af&rid=1&flowid=5c00761b-309a-4695-8784-95b0c6b1ccd8&flowOpation=0&isSelect=0";
            openthiswindow(url);
        }
        
        function openthiswindow(url) {
            var windowObj = "流程处理";          //网页名称，可为空;
            var iHeight = window.screen.height - 250;                         //弹出窗口的宽度;
            var iWidth = window.screen.width - 150;                        //弹出窗口的高度;
            //window.screen.height获得屏幕的高，window.screen.width获得屏幕的宽
            var iTop = (window.screen.height - 10 - iHeight) / 2;       //获得窗口的垂直位置;
            var iLeft = (window.screen.width - 10 - iWidth) / 2;        //获得窗口的水平位置;
            var feature = "width=" + iWidth + ",height=" + iHeight + ",top=" + iTop + ",left=" + iLeft + ",menubar=no,toolbar=no,location=no,scrollbars=no,status=no,modal=yes";
            new_window = window.open(url, 'name', feature);
        }
    });
})();