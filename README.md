


youtube :  https://www.youtube.com/watch?v=Xiybde8JtSk
 
### v2 in development
- [x] Category group feature will be added
- [x] Google Exntetion will be more user-friendly
- A more secure IO-based crud operation using temporary files will be implemented
- [x] Html generator bugs will be fixed
- [x] Pagintaion buttons will be added into main page
  
### v2.1
- [ ] AI based search will be added
- [ ] category_group'lar arasından category taşıma işlemi 
- [ ]  seçilen categpory_group altındaki şeyleri filtrelemek - category group seçilince
- [ ] category ve category delete kısımlarını daha dikkatli ve kullanışlı yapmak - category page içinde 
- [ ] reset atınca category group'unda all olması gerekli - ve category_search_tb'inde temizlenmesi gerekli
 
- [ ] link'in içeriğini hatırlatacak bir image falan eklenebilir 
	- video kapak resmini otomatik çekecek bir sistem yapılabilir şayet ?  youtube bağlantısı ise
	- silme işlemlerinde silinmesi gerekli
	- bir şekilde yedeklemeye bunlarında dahil olması gerekli
	- birden fazla image olabilir
	- ana sayfa düzeninin değiştirilmesi gerekli 
		* bilgi içeriklerinin daha düzgün gösterilmesi gerekli
		* resim olay eklenmeli hover olunca ekranın ortasında gösterilecek şekilde bla bla bla
		* aynı şekilde description alanında (yada link'in üzerine) da hover olunca tooltip ile gösterilebilir tüm daha 
		
-----





# Link Saver

it's a very simple application. i made it for myself because i'm always researching something and i need to save links to web pages. but when there are too many links i forget why i saved them. with this application i solved this problem
with this application you can store and manage all url links
you can add descriptions and categories to them and if you want you can add more than one category.


the application was developed with .net core. I used winfrom. you can run a web server inside the application if you want.

this application has a google extension
I provide a connection between google extension and the app using web server.
using web server and google extension is optional. you can use it if you want.

### application features

- you can work simultaneously with google extension
- you can back up your records
- when registering urls you can add multiple categories, titles and descriptions to them
- You can filter the url by category, title and description
- **If you want to activate the web service, port localhost:5003 should not be in use by another application. You can change the localhost settings in the ApiRun method in program.cs. !!**


## Sample Video Youtube

### *As of 20.10.2024 the ui has been updated, the old ui in this video*




