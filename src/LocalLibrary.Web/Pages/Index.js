$(function () {
    abp.log.debug('Index.js initialized!');
    var link = document.querySelector('a[href="/Account/Login"]');
    link.style.display = 'none';//hide authorization login menu
});
