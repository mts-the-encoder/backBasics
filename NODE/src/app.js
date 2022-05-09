'use strict';

const express = require('express');
const bodyParser = require('body-parser');
const mongoose = require('mongoose');
const config = require('./config');


const app = express();
const router = express.Router();

mongoose.connect(config.connectionString);

//Models
const Product = require('./models/product');
const Customer = require('./models/customer');
const Order = require('./models/order');

// Routes
const index = require('./routes/index'); 
const product = require('./routes/product'); 
const customer = require('./routes/customer'); 
const order = require('./routes/order'); 


app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));

app.use('/', index);
app.use('/products', product);
app.use('/customers', customer);
app.use('/orders', order);

module.exports = app;