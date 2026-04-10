
import socket

client = socket.socket()
client.connect(('localhost', 9999))

name = input("Name: ")
address = input("Address: ")
pps = input("PPS: ")

client.send(f"{name},{address},{pps}".encode())

print("Registration ID:", client.recv(1024).decode())

client.close()
