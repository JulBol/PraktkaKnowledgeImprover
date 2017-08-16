using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWithMVC.Models
{
    public class Proj
    {
        #region properties

        /// <summary>
        /// List of the parts of the projects
        /// </summary>
        public List<Part> Parts { get; set; }

        /// <summary>
        /// Project Name
        /// </summary>
        public string Name { get; set; }
        #endregion


        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Proj()
        {
            Parts = new List<Part>();

        }
        #endregion

        #region Functions

        /// <summary>
        /// Add a part
        /// </summary>
        /// <param name="component"></param>
        /// <param name="name"></param>
        /// <param name="picLink"></param>
        /// <param name="price"></param>
        public void AddPart(string component, string name, string picLink, double price)
        {
            int id = 1;


            // Get list size
            id += Parts.Count();

            // Add a part to the list
            Parts.Add(new Part(id, component, name, picLink, price));
        }


        #endregion

    }
}