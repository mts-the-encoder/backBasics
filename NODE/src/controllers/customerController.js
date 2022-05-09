'use strict';

const ValidationContract = require('../validators/fluent');
const repository = require('../repositories/customer-repository');

exports.post = async (req, res, next) => {
    let contract = new ValidationContract();
    contract.hasMinLen(req.body.name, 3, 'O título deve conter pelo menos 3 caracteres');
    contract.isEmail(req.body.email, 'email Invalido');
    contract.hasMinLen(req.body.password, 6, 'A senha deve conter pelo menos 6 caracteres');

    // se forem inválidos
    if (!contract.isValid()) {
        res.status(400).send(contract.errors()).end();
        return;
    }

    try {
        await repository.create(req.body);
        res.status(201).send({
            message: 'Cadastrado com sucesso! '
        });
    } catch (e) {
        res.status(500).send({
            message: 'Falha ao processar requisição'
        });
    }
}

