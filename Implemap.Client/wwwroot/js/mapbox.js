/** @typedef {{ id: number, latitude: number, longitude: number, name: string }} Location */


/**
 * A function which loads the Mapbox library
 * @param token {string} The token which is used for authentication of the Mapbox library
 */
window.loadMapBox = (token) => {
    mapboxgl.accessToken = token;

    window.map = new mapboxgl.Map({
        /**
         * The ID of the HTML container in which Mapbox should be displayed
         */
        container: 'map',
        /**
         * The URL of the Map style to load (Note: this also contains the data layer)
         */
        style: 'mapbox://styles/viktorvx/cl28zqp75000015pqm7dffov8',
        /**
         * The starting position of the map [longitude, latitude]
         */
        center: [4.90841, 52.3636],
        /**
         * The starting zoom level (how far the map should be zoomed)
         */
        zoom: 11
    });

}

/**
 * A function that adds a location to the map
 * @param location {Location} The location to add to the map
 */
window.addLocationToMap = (location) => {
    const marker = new mapboxgl.Marker().setLngLat([location.longitude, location.latitude]).addTo(window.map);
    marker.getElement().addEventListener('click', () => alert(`Visit location #${location.id}, also known as '${location.name}', all the way over here!`));
}
