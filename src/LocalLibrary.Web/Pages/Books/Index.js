$(function () {
    var l = abp.localization.getResource('LocalLibrary');

    //jerome for GET list
    var dataTable = $('#BooksTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(localLibrary.service.book.getList),
            columnDefs: [

                {
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    action: function (data) {
                                        editModal.open({ id: data.record.id });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    confirmMessage: function (data) {
                                        console.log(data);
                                        return l(
                                            'BookDeletionConfirmationMessage',
                                            data.record.title
                                        );
                                    },
                                    action: function (data) {
                                        localLibrary.service.book
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Title'),
                    data: "title"
                },
                {
                    title: l('Section'),
                    data: "section",
                    render: function (data) {
                        return l('Enum:Section:' + data);
                    }
                },
                //{
                //    title: l('PublishDate'),
                //    data: "publishDate",
                //    render: function (data) {
                //        return luxon
                //            .DateTime
                //            .fromISO(data, {
                //                locale: abp.localization.currentCulture.name
                //            }).toLocaleString();
                //    }
                //},
                {
                    title: l('Author'),
                    data: "author"
                },
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                } 
              

            ]
        })
    );


    //jerome for CREATE LIST
    //popup on the modal
    var createModal = new abp.ModalManager(abp.appPath + 'Books/CreateBookModal');

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewBookButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });

    //EDIT LIST

    var editModal = new abp.ModalManager(abp.appPath + 'Books/EditBookModal');

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });


    var link = document.querySelector('a[href="/Account/Login"]');
    link.style.display = 'none';//hide authorization login menu
});
