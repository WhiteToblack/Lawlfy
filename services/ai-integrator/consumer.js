const amqp = require('amqplib/callback_api');

const rabbitmqUrl = 'amqp://localhost'; // RabbitMQ bağlantı URL'si
const queueName = 'ai-integrator'; // Bu servisin dinleyeceği kuyruk

amqp.connect(rabbitmqUrl, (err, connection) => {
  if (err) {
    throw err;
  }

  connection.createChannel((err, channel) => {
    if (err) {
      throw err;
    }

    channel.assertQueue(queueName, {
      durable: true // Kuyruğun kalıcı olduğundan emin oluyoruz
    });

    console.log(`[*] ai-integrator servisi ${queueName} kuyruğunu dinliyor...`);

    // Mesajları tüketme
    channel.consume(queueName, (msg) => {
      if (msg !== null) {
        const messageContent = msg.content.toString();
        console.log(`[x] ai-integrator Mesaj alındı: ${messageContent}`);

        // Mesaj işleme logic'i burada olacak
        channel.ack(msg); // Mesajın işlendiği bilgisini RabbitMQ'ya gönderiyoruz
      }
    });
  });
});