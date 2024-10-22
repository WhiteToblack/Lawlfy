const amqp = require('amqplib/callback_api');
const CrudService = require('./crudService');

// User servisi için generic CRUD servisini initialize ediyoruz
const userService = new CrudService('user');

amqp.connect('amqp://localhost', (err, connection) => {
    if (err) throw err;

    connection.createChannel((err, channel) => {
        if (err) throw err;

        const queue = 'user_queue';

        channel.assertQueue(queue, { durable: true });
        console.log(`Waiting for messages in ${queue}`);

        channel.consume(queue, async (msg) => {
            const user = JSON.parse(msg.content.toString());
            console.log(`Received message: ${JSON.stringify(user)}`);

            // CRUD işlemi burada yapılır
            try {
                const createdUser = await userService.create(user);
                console.log('User created via RabbitMQ:', createdUser);
            } catch (error) {
                console.error('Error creating user via RabbitMQ:', error.message);
            }

            channel.ack(msg);
        });
    });
});
