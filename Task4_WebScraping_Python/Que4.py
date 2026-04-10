
import requests
from bs4 import BeautifulSoup
import csv

url = "https://books.toscrape.com/catalogue/category/books/travel_2/index.html"
res = requests.get(url)
soup = BeautifulSoup(res.text, 'html.parser')

books = soup.find_all("article", class_="product_pod")

data = []
for book in books:
    name = book.h3.a["title"]
    price = book.find("p", class_="price_color").text
    rating = book.p["class"][1]
    data.append([name, price, rating])

with open("books.csv", "w", newline="") as f:
    writer = csv.writer(f)
    writer.writerow(["Name", "Price", "Rating"])
    writer.writerows(data)

with open("books.csv") as f:
    print(f.read())
