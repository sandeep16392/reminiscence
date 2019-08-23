const mongoose = require('mongoose');

mongoose.connect('mongodb://localhost/reminiscence_test');
mongoose.connection
    .once('open', ()=> console.log('Database Started!'))
    .on('error', (error) => {
        console.warn('Warning', error);
    });