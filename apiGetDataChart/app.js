const express = require('express');
const app = express();
const morgan = require('morgan');
const bodyParser = require('body-parser');

const cors = require('cors');

const routeLabel = require('./routes/labels');
const routeData = require('./routes/data');

app.use(morgan('dev'));
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.use(cors());

app.use('/labels', routeLabel);
app.use('/data', routeData);

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