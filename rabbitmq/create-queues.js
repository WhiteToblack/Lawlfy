const amqp = require('amqplib/callback_api');

// RabbitMQ connection settings
const rabbitmqUrl = 'amqp://localhost'; // Change to your RabbitMQ URL if needed

// List of queues to define for your services
const queues = [
  'accounting',
  'ai-integrator',
  'analytics',
  'authentication',
  'authorization',
  'campaign',
  'document-manager',
  'firm-manager',
  'lawlfy-user',
  'log',
  'notification',
  'ocr',
  'task-manager',
  'unit-of-work'
];

// Function to create queues
function createQueues() {
  amqp.connect(rabbitmqUrl, (err, connection) => {
    if (err) {
      throw err;
    }
    
    // Create a channel to declare queues
    connection.createChannel((err, channel) => {
      if (err) {
        throw err;
      }

      // Iterate over each queue and assert it (create if not exists)
      queues.forEach(queue => {
        channel.assertQueue(queue, {
          durable: true // Make the queue persistent
        });
        console.log(`Queue ${queue} is created or exists`);
      });
    });

    // Close the connection after queue declarations
    setTimeout(() => {
      connection.close();
      process.exit(0);
    }, 500);
  });
}

createQueues();