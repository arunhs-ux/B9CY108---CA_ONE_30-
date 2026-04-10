
import socket
import sqlite3
import uuid

conn = sqlite3.connect("users.db")
cursor = conn.cursor()

cursor.execute("CREATE TABLE IF NOT EXISTS users (id TEXT, name TEXT, address TEXT, pps TEXT)")

server = socket.socket()
server.bind(('localhost', 9999))
server.listen(1)

print("Server started...")

while True:
    client, addr = server.accept()
    data = client.recv(1024).decode()
    name, address, pps = data.split(',')

    reg_id = str(uuid.uuid4())
    cursor.execute("INSERT INTO users VALUES (?, ?, ?, ?)", (reg_id, name, address, pps))
    conn.commit()

    client.send(reg_id.encode())
    client.close()
