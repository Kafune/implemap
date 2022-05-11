# Implemap

> ***Imple***ment ***Map***box

## Introduction

This repository represents a workshop on how to implement [Mapbox](https://www.mapbox.com/) into your .NET application, main use-case being the "InsideAirbnb" assignment.

After this workshop you will know how to create a Mapbox map using Mapbox editors, and how to generate interactive datapoints from code. You can further customize and develop your Mapbox map using the [official documentation](https://docs.mapbox.com/mapbox-gl-js/guides/).

## Prerequisites

### Account
For this workshop, you will need a Mapbox account. You can sign up for free at https://account.mapbox.com/auth/signup/.

### Clone Project
==================== iets van clone this project =========================



## Workshop

The goal of this workshop is to have a working Mapbox example with at least one clickable datapoint. Once you have created an account you can start following these steps.

1. **Installation**. Include the JavaScript and CSS files in the <head> of your HTML file, _Layout.cshtml in Blazor. The CSS file is required to display the map and make elements like Popups and Markers work.

`<script src='https://api.mapbox.com/mapbox-gl-js/v2.8.2/mapbox-gl.js'></script>`<br/>
`<link href='https://api.mapbox.com/mapbox-gl-js/v2.8.2/mapbox-gl.css' rel='stylesheet' />`
  
2. **Create a new style.** On the Mapbox account/dashboard page, go to the studio by clicking *Create a map in Studio*/*Design in Mapbox Studio*. From here, click *New style* and choose a template (basic is recommended, but it's up to you).
  
3. **Get Style URL and Acces Token**. After choosing and locking in your template, the customizing page will open. This is where you can edit styles, colors, visible tags, etc. Under *Share* in the top left corner, scroll to *Developer Resources*. From these we will need the **Style URL** and **Access Token**.
  
  ![image](https://user-images.githubusercontent.com/38245893/167893325-ebeb3dbd-1653-4e31-90e3-1ea9ccdcc74a.png)

4. ======================= hier iets met vervang de uitgecommente code met jouw style url en access token =======================
