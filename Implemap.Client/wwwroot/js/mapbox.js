
// todo: maybe move this somewhere sensible where it still has access to <head>

mapboxgl.accessToken = 'pk.eyJ1IjoidmlrdG9ydngiLCJhIjoiY2wyYWc5aWoyMDU4MDNpc2NpeHRhd3BnbiJ9.0ToPaRrFSK_tM7pZDZR2Ww';

window.loadMapBox = () => {
    const map = new mapboxgl.Map({
        container: 'map', // container ID
        style: 'mapbox://styles/viktorvx/cl28zqp75000015pqm7dffov8', // style URL (also contains data layer)
        center: [4.90841, 52.3636], // starting position [lng, lat]
        zoom: 11 // starting zoom
    });
}
