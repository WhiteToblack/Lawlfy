module.exports = {
    apps: [
        {
            name: 'accounting',
            script: './services/accounting/consumer.js',
            watch: true
        },
        {
            name: 'ai-integrator',
            script: './services/ai-integrator/consumer.js',
            watch: true
        },
        {
            name: 'analytics',
            script: './services/analytics/consumer.js',
            watch: true
        },
        {
            name: 'authentication',
            script: './services/authentication/consumer.js',
            watch: true
        },
        {
            name: 'authorization',
            script: './services/authorization/consumer.js',
            watch: true
        },
        {
            name: 'campaign',
            script: './services/campaign/consumer.js',
            watch: true
        },
        {
            name: 'document-service',
            script: './services/document-service/consumer.js',
            watch: true
        },
        {
            name: 'firm-service',
            script: './services/firm-service/consumer.js',
            watch: true
        },
        {
            name: 'dragonfly',
            script: './services/dragonfly/consumer.js',
            watch: true
        },
        {
            name: 'lawlfy-user',
            script: './services/lawlfy-user/consumer.js',
            watch: true
        },
        {
            name: 'log',
            script: './services/log/consumer.js',
            watch: true
        },
        {
            name: 'notification',
            script: './services/notification/consumer.js',
            watch: true
        },
        {
            name: 'ocr',
            script: './services/ocr/consumer.js',
            watch: true
        },
        {
            name: 'task-manager',
            script: './services/task-manager/consumer.js',
            watch: true
        }
        //   ,
        //   {
        //     name: 'unit-of-work',
        //     script: './services/unit-of-work/consumer.js',
        //     watch: true
        //   }
    ]
};
