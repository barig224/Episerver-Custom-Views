# Custom Views for Episerver CMS.  
Custom Views are a great feature to know about in Episerver for when we as developers want to provide additional information/functionality to the CMS user.  This demo shows four Custom Views in hopes of providing some inspiration for how you can leverage Custom Views to enhance the editor experience on your Episerver website.

## About this solution
This solution was built from a blank Episerver solution with the intent of showcasing the Custom Views feature in Episerver.  There are quite a few files in the solution to handle basic Episerver CMS stuff, so I would focus on the files highlighted below.

All views are built using standard Episerver CMS and ASP.NET MVC.  **NO DOJO REQUIRED!**

When cloned, you can use the user **localadmin ==> Abc123** to access the CMS locally.

To view the Custom Views, navigate to the page titled "The Greatest Play Ever" in Edit Mode.

# Configuration and Setup
In order to setup a custom view, here are the general steps:

## 1) Create a View Configuraiton
Create a class to register a new Custom view.

### Relevant Files
- ~/Business/ViewConfigurations.cs

## 2) Register the Route
Since we are using an iFrame and setting a route, we need to make sure the view path routes to something

### Relvant Files
- ~/Global.asax

## 3) Create Your Controller
Create a Controller to handle the request when a user switches to the new Custom view

### Relevant Files
- All the files in ~/Controllers/CustomViewControllers

## 4) Create Your View
Display what you want the user to see when they switch to the Custom View

### Relevant Files
- The .cshtml files in the ~/Views root folder

# About the Included Custom Views
This solution comes with four Custom View examples.  Note that the content rendered generally speaking is hard-coded...these are intended just to give you an idea of the types of things you could do.  These are not intended to be dropped and used "out of box", as you will be very dissapointed :)

## Informational Custom Views (ex:  About this Page Type Custom View)
Use a Custom View to provide helpful information to the CMS Editor.  This is useful if you have companion documentation paired with your implementation...consider using a Custom View to display that documentation directly with the page itself.

## In-depth Custom Views (ex:  SEO Properties Custom View)
Use a Custom View when certain properties have robust best practice information which you cannot fit into just the Description property.  Can also use these for complex validation/analysis of entered properties.

## Integrated Custom Views (ex:  Production Info Custom View)
Sometimes relevant information about a particular page lives in an external system.  You can use a Custom View to display this information to the CSM Editor.

## Custom Property Editor Views (ex:  Hero Editor Custom View)
If you have a complex property and cannot figure out how to make on-page editing work, you can utilize a Custom View instead.  This lets you build an editor experience strictly using MVC instead of having to mess with Dojo.

# Further Reading
I found the following articles to be helpful while developing this demo.
- [Adding Custom Views to Your Content](https://world.episerver.com/blogs/Linus-Ekstrom/Dates/2014/4/Adding-custom-views-to-your-content/)
- [Custom Views](https://world.episerver.com/blogs/Duong-Nguyen/Dates/2013/12/Custom-views-and-plugin-areas-in-EPiServer-75/)
- [Displaying a Custom On-Page Editing View](http://www.jondjones.com/learn-episerver-cms/episerver-developers-guide/episerver-customizing-episervers-ui/displaying-a-custom-on-page-editing-view)
