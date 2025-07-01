import axios from 'axios';

const API_URL = import.meta.env.VITE_API_URL;


export const getGifRandom = async (id) => {
  return await axios.get(`${API_URL}gif/${id}`);
};

export const getHistory = async () => {
  return await axios.post(`${API_URL}history`);
};