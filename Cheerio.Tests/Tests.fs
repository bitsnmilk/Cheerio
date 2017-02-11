module Cheerio.Tetsts

open System
open Xunit
open Cheerio

[<Fact>]
let ``test foo``() =
    let expected = 6
    let actual = foo 3 3
    Assert.Equal(expected, actual)