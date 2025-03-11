using System.Windows;

namespace HB.LinkSaver
{
    public class HtmlGenerator 
    {
        private List<Link> Links;

        public HtmlGenerator(List<Link> links)
        {
            Links = links;
        }

        

        public string GenerateGtml()
        {

            var html = $@"<!DOCTYPE html>
                <html lang=""en"">
                <head>
                    <meta charset=""UTF-8"">
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                    <title>Link Saver Backup</title>
                    <style>
                        body {{
                            display: flex;
                            justify-content: center;
                            align-items: center;
                            height: 100vh;
                            margin: 0;
                            background-color: #f5f5f5;
                        }}
                        table {{
                            border-collapse: collapse;
                            width: 90%;
                            margin: auto;
                            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
                        }}
                        th, td {{
                            padding: 12px 15px;
                            text-align: center;
                            border: 1px solid #ddd;
                            
                        }}
                        th {{
                            background-color: #2da1b6;
                            color: white;
                        }}

                        tr:nth-child(even) {{
                            background-color: #f2f2f2;
                        }}
                        tr:nth-child(odd) {{
                            background-color: #ffffff;
                        }}





                        tr:hover {{
                            background-color: #ddd;
                        }}
                        caption {{
                            caption-side: top;
                            font-size: 24px;
                            font-weight: bold;
                            margin-bottom: 10px;
                        }}


                     th:nth-child(1), td:nth-child(1) {{width: 15%;
                            }}
                            th:nth-child(2), td:nth-child(2) {{width: 40%;
                            }}
                            th:nth-child(3), td:nth-child(3) {{width: 15%;
                            }}
                            th:nth-child(4), td:nth-child(4) {{width: 30%;
                            }}
                            ul {{list-style-type: none;
                            }}

                    li{{

                        border : 1px solid black;
                        padding: 3px;
                        margin: 3px;
                      }}

                    </style>
                </head>
                <body>

                    {LinkToHtmlTable(Links)}

                </body>
                </html>";

            return html;
        }

        private string LinkToHtmlTable(List<Link> links)
        {

            var table = $@"
                    
                        
                        <table>
                     <caption>
                                        <h1 style=""text-align: center;"">LinkSaver Backup</h1>
                                        <h4 style=""text-align: center;""> Date  {DateTime.Now.ToString()} </h4>
                          </caption>
                        
                            <thead>
                                <tr>
                                    <th>Header</th>
                                    <th>Description</th>
                                    <th>Link</th>
                                    <th>Category</th>
                                </tr>
                            </thead>
                             <tbody>
                                    {TableBodyGenerator(links)}
                               </tbody>
                        </table>";

            return table;
        }
        private string TableBodyGenerator(List<Link> links)
        {
            var temp = "";

            foreach (var link in links)
            {
                temp += "<tr>";
                temp += $"<td>{link.Header}</td>";
                temp += $"<td>{link.Description}</td>";
                temp += @$"<td>  <a href=""{link.Content}"" target=""_blank""> Link  </a> </td>";
                temp += "<td>";
                temp += "<ul>";
                foreach (var category in link.Categories)
                {
                    
                    temp += $"<li> {category} </li>";
                }
                temp += "</ul>";
                temp += "</td>";
                temp += "</tr>";
                temp += Environment.NewLine;
            }
            return temp;
        }
    }
}
