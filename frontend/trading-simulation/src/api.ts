import axios from "axios";

const api = axios.create({ baseURL: "http://localhost:5252/api" });

export const getPrice = async () => {
  const response = await api.get("/price");
  return response.data;
};

export const placeOrder = async (order: {
  price: number;
  quantity: number;
}) => {
  const response = await api.post("/order", order);
  return response.data;
};
