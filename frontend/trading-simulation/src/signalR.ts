import { HubConnectionBuilder } from "@microsoft/signalr";

export const startSignalR = (onReceivePrice: (price: any) => void) => {
  const connection = new HubConnectionBuilder()
    .withUrl("http://localhost:5252/marketdatahub")
    .build();

  connection.on("ReceivePrice", onReceivePrice);
  connection.start();
};
