'use strict';

let config = require('../config');
let sendgrid = require('sendgrid')(config.sendgirdKey);

exports.send = async (to, subject, body) => {
    sendgrid.send({
        to: to,
        from: 'hello@balta.io',
        subject: subject,
        html: body
    });
}