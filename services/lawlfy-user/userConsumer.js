const CrudService = require('../../custom-library/crudService');

// User servisi için generic CRUD servisini initialize ediyoruz
const userService = new CrudService('user');

// Kullanıcı oluşturma örneği
async function createUser() {
    const newUser = {
        name: 'Jane Doe',
        email: 'janedoe@example.com',
        password: 'password123'
    };
    const createdUser = await userService.create(newUser);
    console.log('Created User:', createdUser);
}

// Kullanıcıları listeleme
async function listUsers() {
    const users = await userService.getAll();
    console.log('All Users:', users);
}

// Kullanıcı güncelleme örneği
async function updateUser(userId) {
    const updatedUser = {
        id: userId,
        name: 'Jane Doe Updated',
        email: 'janedoe.updated@example.com',
        password: 'newpassword456'
    };
    await userService.update(userId, updatedUser);
    console.log('User updated');
}

// Kullanıcı silme örneği
async function deleteUser(userId) {
    await userService.delete(userId);
    console.log(`User with ID ${userId} deleted`);
}

// Kullanım örnekleri
createUser();
listUsers();
updateUser(1);  // ID'si 1 olan kullanıcıyı güncelle
deleteUser(1);  // ID'si 1 olan kullanıcıyı sil
