# ImpleMap

> ***Imple***ment ***Map***box

## Introduction

This repository represents a workshop on how to implement [Mapbox](https://www.mapbox.com/) into your .NET application, main use-case being the "InsideAirbnb" assignment.

After this workshop you will know how to create a Mapbox map using Mapbox editors, and how to generate interactive datapoints from code. You can further customize and develop your Mapbox map using the [official documentation](https://docs.mapbox.com/mapbox-gl-js/guides/).


## Prerequisites

### Account
For this workshop, you will need a Mapbox account. You can sign up for free at https://account.mapbox.com/auth/signup/.

### Clone Project
Clone this project and open it with ***Visual Studio 2022 Preview***. Make sure you have a ***7.0+ dotnet SDK*** installed.



## Workshop

The goal of this workshop is to have a working Mapbox example with clickable datapoints and a searchbar. Once you have created an account you can start following these steps.

1. **Installation**. Include the [Mapbox installation](https://docs.mapbox.com/mapbox-gl-js/guides/install/) JavaScript and CSS files in the `<head>` of your HTML file (`\Implemap.Client\Pages\_Layout.cshtml` in Blazor). The CSS file is required to display the map and make elements like Popups and Markers work. Also add the [Mapbox Geocoder Plugin](https://docs.mapbox.com/mapbox-gl-js/example/mapbox-gl-geocoder/) tags, which will be used to add a searchbar later. You should have the following tags in the `<head>` of your HTML file:

`<script src='https://api.mapbox.com/mapbox-gl-js/v2.8.2/mapbox-gl.js'></script>`<br/>
`<script src="https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-geocoder/v5.0.0/mapbox-gl-geocoder.min.js"></script>`<br/>
`<link href='https://api.mapbox.com/mapbox-gl-js/v2.8.2/mapbox-gl.css' rel='stylesheet' />`<br/>
`<link rel="stylesheet" href="https://api.mapbox.com/mapbox-gl-js/plugins/mapbox-gl-geocoder/v5.0.0/mapbox-gl-geocoder.css" type="text/css">`<br/>
  
2. **Create a new style.** On the Mapbox account/dashboard page, go to the studio by clicking *Create a map in Studio*/*Design in Mapbox Studio*. From here, click *New style* and choose a template (basic is recommended, but it's up to you).
  
3. **Get Style URL and Acces Token**. After choosing and locking in your template, the customizing page will open. This is where you can edit styles, colors, visible tags, etc. Under *Share* in the top left corner, scroll to *Developer Resources*. From these we will need the **Style URL** and **Access Token**.
  
  ![image](https://user-images.githubusercontent.com/38245893/167893325-ebeb3dbd-1653-4e31-90e3-1ea9ccdcc74a.png)

4. **Configuration.** Now that we have our credentials we can load mapbox into our application. Copy your **Access Token** and paste it in the `MapboxToken` field in `Implemap.Client\appsettings.Development.json`. Next, copy your **Style URL** and paste it into the `style` field in the Map constructor in `\Implemap.Client\wwwroot\js\mapbox.js`. With this, mapbox can be loaded into your webpage. Give it a try!

5. ***Starting Multiple VS Projects** In case Visual Studio only gives the option to start either the client or the api, right click the Solution file in the Solution Explorer and Click **Properties**. Under the **Startup Project** tab choose **Multiple Startup Projects** and set both project to 'Start'.*

6. **Markers.** In this step we will add the actual clickable markers to our code. Uncomment the `window.addLocationToMap` function at the bottom of `\Implemap.Client\wwwroot\js\mapbox.js`. This function creates new markers for our datapoints. Also uncomment the two lines that call this function in the `OnAfterRenderAsync` function in `Implemap.Client\Pages\Map\MapIndex.razor`. Now our page will fetch the location data from our backend and place add it to the Mapbox map.

7. **Searchbar.** Finally, uncomment the `window.map.addControl` function in `\Implemap.Client\wwwroot\js\mapbox.js` to add a searchbar to your Mapbox map. And with that, you have a fully functional, interactive map with minimal effort.
