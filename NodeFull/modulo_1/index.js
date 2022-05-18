function getUser(callback) {
    setTimeout(() => {
        return callback(null, {
            id: 1,
            name: 'Guile',
            bornDate: new Date()
        });
    }, 1000);
}

function getPhone(idUser, callback) {
    setTimeout(() => {
        return callback(null, {
            number: '40028933',
            ddd: 11
        })
    }, 2000);
}

function getAdress(idUser, callback) {
    setTimeout(() => {
        return callback(null, {
            street: 'folks',
            number: 0
        })
    }, 2000);
}

function resolveUser(error, user) {
    console.log(`Usuário: ${user}`);
}

getUser(function resolveUser(error, user) {
    if (error) {
        console.log('not', error)
        return;
    }
    getPhone(user.id, function resolvePhone(error1, phone) {
        if (error1) {
            console.log('not', error1)
            return;
        }
        getAdress(user.id, function getAdress(error2, adress) {
            if (error2) {
                console.log('not', error2)
                return;
            }
            console.log(`
                name: ${user.name},
                adress: ${adress.street}, ${adress.number}
                phone: (${phone.ddd})(${phone.number})
            `);
        })
    });
});