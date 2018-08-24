//
// LocationBias.cs
//
// Author:
//       Ahmed Aglan <Aglan@MpsEgypt.com>
//
// Copyright (c) 2017 (c) Ahmed Aglan
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace SearchPlaces
{
	/// <summary>
	/// LocationBias object enables location biasing for PlacesBar Google Places API requests
	/// </summary>
	public class LocationBias
	{
		/// <summary>
		/// The latitude.
		/// </summary>
		public readonly double latitude;

		/// <summary>
		/// The longitude.
		/// </summary>
		public readonly double longitude;

		/// <summary>
		/// The radius.
		/// </summary>
		public readonly int radius;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:SearchPlaces.LocationBias"/> class.
		/// </summary>
		/// <param name="latitude">Latitude.</param>
		/// <param name="longitude">Longitude.</param>
		/// <param name="radius">Radius.</param>
		public LocationBias(double latitude, double longitude, int radius)
		{
			this.latitude = latitude;
			this.longitude = longitude;
			this.radius = radius;
		}

		/// <summary>
		/// Returns a formatted <see cref="T:System.String"/> 
		/// that represents the current <see cref="T:SearchPlaces.LocationBias"/> for PlacesBar API calls.
		/// </summary>
		/// <returns>A formatted <see cref="T:System.String"/> 
		/// that represents the current <see cref="T:SearchPlaces.LocationBias"/> for PlacesBar API calls..</returns>
		public override string ToString()
		{
			return $"&location={latitude},{longitude}&radius={radius}";
		}
	}

}
