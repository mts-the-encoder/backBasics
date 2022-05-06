'use strict';

const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');

const app = express();
const router = express.Router();

const user = 'mts';
const passwd = 'urubu100';

mongoose.connect(`mongodb+srv://${user}:${passwd}@cluster0.jhaxa.mongodb.net/Data`);

//Models
const Product = require('./models/product');

// Routes
const index = require('./routes/index'); 
const product = require('./routes/product'); 


app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));

app.use('/', index);
app.use('/products', product);

module.exports = app;