
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkSaveR.CRUD
{
    public class Crud
    {
        
        public static List<Category> GetCategories()
        {
            using (var db = new AppDbContext())
            {


                var data = db.Categories.ToList();
                return data;

            }
        }
        public static List<Link> GetLinks()
        {
            using (var db = new AppDbContext())
            {

                var data = db.Links.Include(x => x.Category).ToList();
                return data;

            }


        }
        
    
        public static void LinkAdd(Link link)
        {
            using (var db = new AppDbContext())
            {

                db.Links.Add(link);
                db.SaveChanges();
            }
        }

        public static void DeleteLink(int id)
        {
            if (id == -1)
            {
                MessageBox.Show("pls select a link ");
                return;
            }
            using (var db = new AppDbContext()) 
            {

                var link = db.Links.Find(id);
                if (link == null)
                {
                    MessageBox.Show("link not found pls restart the application");
                    return;
                }
                db.Links.Remove(link);
                db.SaveChanges();
            
            }
        }

        public static void UpdateCategory(int id, string name)
        {
            using (var db = new AppDbContext())
            {
                var category = db.Categories.Find(id);

                category.Name = name;
                db.SaveChanges();

            }
        }

        public static void DeleteCategory(int id)
        {
            using (var db = new AppDbContext())
            {
                var category = db.Categories.Find(id);

                db.Categories.Remove(category);
                db.SaveChanges();


            }
        }

        public static List<Link> GetLinkByCategoryId(int id)
        {


            using (var db = new AppDbContext())
            {
                var data = db.Links.Where(x => x.CategoryId == id).ToList(); 
                return data;
            }

        }



    }
}
