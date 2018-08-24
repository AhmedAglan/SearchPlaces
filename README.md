# SearchPlaces
An extension of Xamarin.Forms SearchBar control for implementing Google Places Autocomplete API

## NuGet package
https://www.nuget.org/packages/SearchPlaces/

## Obtaining API key
Use the Google Developers Console to enable the 'Google Places API Web Service' and create a new API key.

## Usage

### The PlacesBar has the following properties and methods:

#### Type
An optional PlaceType value that sets the results based on a particular location Type

#### Bias
An optional LocationBias value that sets a custom location bias (see API docs for details)

#### ApiKey
A required string value

#### MinimumSearchText
An optional integer value for setting the minimum number of search characters the user should type before API calls are made (useful for stemming API call volume)

#### PlacesRetrieved
Subscribe to this event handler to receive search results as AutoCompleteResults objects

#### Retrieving Place details
The package also contains classes you can use to retrieve place details (including Latitude & Longitude)

#### Places class
A static class which exposes a GetPlace(placeID, apiKey) function which returns a Place object

#### Place class
A Place object contains Name, Latitude, Longitude and Raw (JSON response string) properties
