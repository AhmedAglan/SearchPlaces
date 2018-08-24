//
// PlaceType.cs
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
	/// Place type.
	/// </summary>
	public enum PlaceType
	{
		///<summary>Get all place types</summary>
		All,
		///<summary>Get geocode place types</summary>
		Geocode, 
		///<summary>Get address place types</summary>
		Address, 
		///<summary>Get establishment place types</summary>
		Establishment, 
		///<summary>Get regional place types</summary>
		Regions, 
		///<summary>Get city place types</summary>
		Cities
	}

}
