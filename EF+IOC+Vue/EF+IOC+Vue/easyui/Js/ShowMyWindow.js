$(function () {
    $('body').append('<div id="myWindow" class="easyui-dialog" closed="true"></div>');
});
function showMyWindow(title, href, width, height, modal, minimizable,
        maximizable) {
    $('#myWindow').window(
                    {
                        title: title,
                        width: width === undefined ? 600 : width,
                        height: height === undefined ? 400 : height,
                        content: '<iframe scrolling="yes" frameborder="0"  src="'
                                + href
                                + '" style="width:100%;height:98%;"></iframe>',
                        modal: modal === undefined ? true : modal,
                        minimizable: minimizable === undefined ? false
                                : minimizable,
                        maximizable: maximizable === undefined ? false
                                : maximizable,
                        shadow: false,
                        cache: false,
                        closed: false,
                        collapsible: false,
                        resizable: false,
                        loadingMessage: '正在加载数据，请稍等片刻......'
                    });
}