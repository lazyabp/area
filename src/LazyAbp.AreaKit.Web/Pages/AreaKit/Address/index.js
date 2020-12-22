$(function () {

    var l = abp.localization.getResource('AreaKit');

    var service = lazyAbp.areaKit.address;
    var createModal = new abp.ModalManager(abp.appPath + 'AreaKit/Address/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'AreaKit/Address/EditModal');

    var dataTable = $('#AddressTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('AreaKit.Address.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('AreaKit.Address.Delete'),
                                confirmMessage: function (data) {
                                    return l('AddressDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                        service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            { data: "firstName" },
            { data: "lastName" },
            { data: "fullName" },
            { data: "company" },
            { data: "county" },
            { data: "address1" },
            { data: "address2" },
            { data: "postCode" },
            { data: "email" },
            { data: "phoneNumber" },
            { data: "faxNumber" },
            { data: "tag" },
            { data: "isDefault" },
            { data: "displayOrder" },
            { data: "country" },
            { data: "stateProvince" },
            { data: "city" },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewAddressButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});