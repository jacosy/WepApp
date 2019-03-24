
(function IIEF() {
    var url = window.location.origin + '/System';

    var editor = new $.fn.dataTable.Editor({
        ajax: {
            create: {
                type: 'POST',
                url: url + '/Create'
            }
        },    
    //        remove: {
    //            type: 'DELETE',
    //            url: url + '/Delete?accountId=_id_'
    //        }
    //    },
        table: "#accountTable"
        //template: '#accountModal'
    });

    $(document).ready(function () {
        $('#accountTable').DataTable({
            dom: "Bfrtip",
            processing: true,
            //serverSide: true,
            ajax: {
                url: url + '/GetData',
                type: 'GET',
                dataType: 'json',
                data: { id: 1 },
                dataSrc: function (result) {
                    return result.data;
                }
                //success: function (result) {
                //    return result;
                //}            
            },
            columns: [
                {
                    data: null,
                    render: function (data, type, row) {
                        var template = "<button type='button' class='btn btn-primary' data-toggle='modal' data-target='#accountModal'></button>";
                        return template;
                    },
                    orderable: false
                },
                { data: "Account" },
                { data: "UserName" },
                { data: "Email" },
                { data: "Role" },
                { data: "AccountStatus" },
                { data: "ValidStartTime" },
                { data: "ValidEndTime" },
                { data: "LastLoginIP" },
                { data: "LastLoginTime" }
            ],
            order: [1, 'asc'],
            select: true,
            select: {
                style: 'os',
                selector: 'td:first-child'
            },            
            buttons: [
                { extend: "create", editor: editor }
            //    { extend: "remove", editor: editor }
            ]
        });
    });

    function openModal(id) {
        alert(id);
        $('#accountModal').modal('show');
    }
})();
