### Hi there š

This is āØ _My Dev Blog_ āØ repository. `()=>` [Check me out](https://bloggrammer.com/).

Here are some ideas to get you started:

- š­ Iām currently working on SaaS marketing products
- š± Iām currently learning frontend web and mobile development
- šÆ Iām looking to collaborate on NLP related projects
- š¤ Iām looking for help with IoT development
- š¬ Ask me about SEO and app development
- š« How to reach me: hello@bloggrammer.com
- š Pronouns: ...
- ā” Fun fact: programming gimme brains but blogging add liver.

## About Bloggrammer
`Blogger + Programmer  == Bloggrammer` is a simple, clean and respnsive dev blog. It incorporates various widget areas that makes management of sidebar content a lots easier, especially for ad-suported sites. The site's development focuses on minimizing HTTP requests to help conserve server resource. 

## Preview

### Screenshot

### Live site: [Here](https://bloggrammer.com/)

## TOC
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Generating static files](#generating-static-files)
- [Files/Folder Structure](#filesfolders-structure)
- [Deployment](#deployment)
- [Built With](#built-with)
- [Changelog](#contribution)
- [Authors](#authors)
- [License](#license)

## Getting Started
In order to run **Bloggrammer** on your local machine all what you need to do is to have the prerequisites stated below installed on your machine. 

#### Prerequisites
  - CSC.exe is the CSharp compiler included in the .NET Framework
  - Text Editor
  - CLI
 
 *CSC.exe is found in the .NET Framework directory, e.g. for .NET 3.5, c:\windows\Microsoft.NET\Framework\v3.5\.*
 
#### Generating static files
To generate the static files alocated at the **wwwroot** directory, first open a Powershell window, go to the clone folder (e.g. c:\blogrammer\) and run the following

```
> C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe SiteGenerator.cs 
> .\SiteGenerator 
```
#### Open website
Open the static files alocated at the **wwwroot** directory in a browser.

## Files/Folders Structure
Here is a brief explanation of the template folder structure and some of its main files usage:
```
āāā dev                         # Contains all development source files.
ā   āāā content                 # Contains JS, CSS, images and icon fonts.
ā   ā   āāā category            # Contains all JavaScript files.
ā   ā   āāā pages               # Contains all JavaScript files.
ā   ā   āāā posts               # Contains all JavaScript files.
ā   ā
ā   āāā include                 # Contains JS, CSS, images and icon fonts.
ā   ā   āāā category            # Contains all JavaScript files.
ā   ā   āāā icon                # Contains all JavaScript files.
ā   ā   āāā rating              # Contains all JavaScript files.
ā   ā   āāā *.shtml             # Contains all JavaScript files.
ā   ā  
ā   āāā scss                    # Contains all SCSS files.
ā   ā   āāā global              # Contains all JavaScript files.
ā   ā   āāā mixins              # Contains all JavaScript files.
ā   ā   āāā site                # Contains all JavaScript files.
ā   ā   āāā utils               # Contains all JavaScript files.
ā   ā   āāā main.scss           # Contains all JavaScript files.
ā   ā 
āāā wwwroot                     # Contains static files.
ā   āāā assets                  # Contains JS, CSS, images and icon fonts.
ā   ā   āāā js                  # Contains all JavaScript files.
ā   ā   āāā cs                  # Contains all CSS files.
ā   ā   āāā img                 # Contains all site images.
ā   āāā *.html                  # All HTML pages files .
ā   āāā sitemap.xml             # Contains site metadata for web crawlers.
ā   āāā index.xml               # Contains rss feed.
ā   āāā robots.txt              # Contains instructions for web scrapers.
ā   āāā .htaccess               # Apache server config code.
ā
āāā .gitattributes              # Git Attributes.
āāā .gitignore                  # Ignored files in Git.
āāā LICENSE                     # Licensing.
āāā README.md                   # Manual file.
āāā SiteGenerator.cs            # C# site generator file.
āāā SiteGenerator.exe           # Compiled C# site generator file.
```
## Deployment
The demo website is deployed on a shared hosting with [InMotionHosting](https://www.inmotionhosting.com/) 

## Built With
- [HTML5](https://developer.mozilla.org/en-US/docs/Web/HTML)
- [Sass](http://sass-lang.com/)
- [JavaScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript)
- [AutoPrefixer](https://autoprefixer.github.io/)
- [Prism](https://prismjs.com/)
- [Giscus](https://giscus.app/)
## Contribution

## Authors
[John Ansa](https://linkedin.com/in/johnansa)

## License
[Bloggrammer](https://bloggrammer.com/) is an open source project by [John Ansa](https://linkedin.com/in/johnansa) that is licensed under [The MIT License (MIT)](https://opensource.org/licenses/MIT). Which means that you can use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the final products. But remember, John Ansa reserves the right to change the license of future releases.
