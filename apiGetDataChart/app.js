const express = require('express');
const app = express();
const morgan = require('morgan');
const bodyParser = require('body-parser');


const routeLabel = require('./routes/labels');

app.use(morgan('dev'));
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.use('/labels', routeLabel);

app.use((req, res, next) => {
    const err = new Error('not found');
    err.status(404);
    next(err);
});

app.use((error, req, res, next) => {
    res.status(error.status || 500);
    return res.send({
        erro: {
            message: error.message
        }
    });
});

module.exports = app;