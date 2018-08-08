(function($) {
    $(document).ready(function($) {
        $("#getOrdersBtn").click(function() {
            showOrders();
        });

        function getOrderList(callback) {
            $.ajax({
                url: `http://${location.hostname}:${location.port}/Order/GetOrders`,
                //contentType: 'application/json',
                success: function(data) {
                    callback(data);
                }
            });
        }

        function showOrders() {
            getOrderList(function (list) {
                var h = -1, html = [];
                if (list) {
                    for (var i = 0; i < list.length; i++) {
                        var order = list[i];
                        html[++h] = `OrderId: ${order.OrderId}\n`;
                        html[++h] = `AccountNumber: ${order.AccountNumber == -1 ? undefined : order.AccountNumber} \n`;
                        html[++h] = `CustomerName: ${order.CustomerName} \n`;
                        var serviceCount = order.Services ? order.Services.length : 0;
                        html[++h] = `Service Count: ${serviceCount} \n\n`;
                    }
                    $("#orderListArea").val(html.join(""));
                }
            })
        }

        showOrders();
    });
})(jQuery)