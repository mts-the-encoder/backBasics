const express = require('express');
const app = express();
const morgan = require('morgan');
const bodyParser = require('body-parser');

const cors = require('cors');

// const routeLabel = require('./routes/labels');
// const routeData = require('./routes/data');
const routeCpu = require('./routes/cpu');
const routeRam = require('./routes/ram');
const routeDisc = require('./routes/disc');

app.use(morgan('dev'));
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.use(cors());

// app.use('/labels', routeLabel);
// app.use('/data', routeData);
app.use('/cpu', routeCpu);
app.use('/ram', routeRam);
app.use('/disc', routeDisc);

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