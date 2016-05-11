﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Android.App;
using Android.Widget;
using Android.OS;
using ExcellaCareers.Model;
using ExcellaCareers.Services;
using ExcellaCareers.Services.Impl;
using HtmlAgilityPack;

namespace ExcellaCareers.Droid
{
    [Activity (Label = "Excella Careers", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        private readonly IHtmlScraper htmlScraper;

        private readonly ICareerHtmlParser careerHtmlParser;
        
        public MainActivity()
        {
            this.htmlScraper = new HtmlScraper();
            this.careerHtmlParser = new CareerHtmlParser();
        }

        protected override async void OnCreate (Bundle bundle)
        {
            base.OnCreate (bundle);
            SetContentView (Resource.Layout.Main);
            
            var webResponse = await this.htmlScraper.Scrape(Resources.GetString(Resource.String.careers_url));

            var jobs = this.careerHtmlParser.ParseHtml(webResponse);
            
            this.ListAdapter = new JobListItemAdapter(this, Resource.Layout.CareerListItem, jobs.ToList());
        }
    }
}


