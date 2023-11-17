import axios from 'axios';

export const shopApiService = axios.create({
	baseURL: '',
	timeout: 1000,
});

