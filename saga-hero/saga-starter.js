const amqp = require('amqplib/callback_api');

function startSaga(message) {
    // RabbitMQ'ya mesaj gönder
    sendMessageToService('lawlfy-user', message);
}

function sendMessageToService(serviceName, message) {
    amqp.connect('amqp://localhost', function(error0, connection) {
        if (error0) {
            throw error0;
        }
        connection.createChannel(function(error1, channel) {
            if (error1) {
                throw error1;
            }
            const queue = serviceName;

            channel.assertQueue(queue, {
                durable: true
            });

            channel.sendToQueue(queue, Buffer.from(JSON.stringify(message)));

            console.log(" [x] Sent %s", message);
        });
    });
}

startSaga({ user: "WhiteToBlack", action: "register" });
