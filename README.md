# ITS-462-Final
**Repository for information and source control for 462**

**App Requirements**

* The application will retrieve (scrape) product description, product spec, price and discount information
from a scraper test site (https://webscraper.io/test-sites/e-commerce/allinone) and store the information in a database.
* The application will have a Windows form for specifying what data item or items to scrape and store in
a database.
* The application will have Windows form(s) for displaying the scraped data in the database.
* The application will have a query capability to search for specific data in the relational database and
display it in a Windows form.
* The application will use a tool to scrape a website to extract information such as htmlagilitypack (see
Technical Tip below) that can be integrated into the application as a NuGet package. An alternate tool
can be used. The HTML Agility Pack tool scrapes HTML and builds a DOM with the scraped data
(XPATH and XSLT is supported).
* The application will be a desktop C# Windows Forms application.
* The extracted data will be stored in a SQLite or Microsoft Access relational database.
* A Software Requirements Specification will be compiled for the application. 

**Job Breakdown**

**James** will handle the webscrapping of information to the C# application and hold that into object/classses of the app. **Pedro** will then take the information scrapped and add that to the sqlite or access database. We will then come together to fulfill the software requirement specifications sheet for the application. We will also cooperate to ensure database integrity and proper information transference.
