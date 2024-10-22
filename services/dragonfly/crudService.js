const axios = require('axios');

// Base URL - API'nin ana URL'sini burada tanımlayabilirsiniz
const BASE_URL = 'http://localhost:5000/api';

/**
 * Generic CRUD Service
 * @param {string} serviceUrl - API servisi için base URL
 */
class CrudService {
    constructor(serviceUrl) {
        this.serviceUrl = `${BASE_URL}/${serviceUrl}`;
    }

    /**
     * Get all items
     * @returns {Promise<any>}
     */
    async getAll() {
        try {
            const response = await axios.get(this.serviceUrl);
            return response.data;
        } catch (error) {
            this.handleError(error);
        }
    }

    /**
     * Get item by ID
     * @param {number} id - Item ID
     * @returns {Promise<any>}
     */
    async getById(id) {
        try {
            const response = await axios.get(`${this.serviceUrl}/${id}`);
            return response.data;
        } catch (error) {
            this.handleError(error);
        }
    }

    /**
     * Create new item
     * @param {Object} item - Item data to create
     * @returns {Promise<any>}
     */
    async create(item) {
        try {
            const response = await axios.post(this.serviceUrl, item);
            return response.data;
        } catch (error) {
            this.handleError(error);
        }
    }

    /**
     * Update item by ID
     * @param {number} id - Item ID
     * @param {Object} item - Updated item data
     * @returns {Promise<any>}
     */
    async update(id, item) {
        try {
            const response = await axios.put(`${this.serviceUrl}/${id}`, item);
            return response.data;
        } catch (error) {
            this.handleError(error);
        }
    }

    /**
     * Delete item by ID
     * @param {number} id - Item ID
     * @returns {Promise<void>}
     */
    async delete(id) {
        try {
            await axios.delete(`${this.serviceUrl}/${id}`);
        } catch (error) {
            this.handleError(error);
        }
    }

    /**
     * Handle errors from axios requests
     * @param {Error} error - Error object
     */
    handleError(error) {
        if (error.response) {
            console.error('Error response data:', error.response.data);
        } else {
            console.error('Error:', error.message);
        }
    }
}

module.exports = CrudService;
