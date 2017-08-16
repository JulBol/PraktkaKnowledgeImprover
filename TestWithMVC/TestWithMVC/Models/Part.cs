using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWithMVC.Models
{
    /// <summary>
    /// Part of a Project
    /// </summary>
    public class Part
    {
        #region Properties
        /// <summary>
        /// Id of the Part
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Component of the Part
        /// </summary>
        public string Component { get; set; }

        /// <summary>
        /// Name of the Part
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// PicLink of the Part
        /// </summary>
        public string PicLink { get; set; }

        /// <summary>
        /// Price of the Part
        /// </summary>
        public double Price { get; set; }
        #endregion


        #region constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="component"></param>
        /// <param name="name"></param>
        /// <param name="picLink"></param>
        /// <param name="price"></param>
        public Part(int id, string component, string name, string picLink, double price)
        {
            Id = id;
            Component = component;
            Name = name;
            PicLink = picLink;
            Price = price;
        }
        #endregion
    }
}