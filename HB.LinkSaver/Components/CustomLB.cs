using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HB.LinkSaver.Components
{
    public class CustomLB:ListBox
    {

        public CustomLB()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed; // Özel çizim modu
        }



        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= this.Items.Count)
                return;


  

            // Arka plan rengini belirle
            Color backgroundColor = (e.Index % 2 == 0) ? Color.FromArgb(40, 40, 40) : Color.FromArgb(30, 30, 30);

            // Arka plan rengini uygula
             e.DrawBackground();
            //e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

            Rectangle paddedBounds = new Rectangle(e.Bounds.X + 5, e.Bounds.Y + 5, e.Bounds.Width - 10, e.Bounds.Height - 10);
            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), paddedBounds);


            // Item metnini çiz
            e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font, Brushes.White, e.Bounds);

            // Çizimi tamamla
            e.DrawFocusRectangle();
        }
       
    }
}
