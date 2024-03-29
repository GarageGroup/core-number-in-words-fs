﻿namespace GGroupp.Core.Tests.NumberInWordsTest

open Xunit
open GGroupp
open GGroupp.NumberInWords
open GGroupp.Core.Tests.TestHelper

module ToWordsInRussianWithDimensionTest =

    [<Literal>]
    let private Empty = ""

    [<Literal>]
    let private MasculineCode = 0

    [<Literal>]
    let private FeminineCode = 1

    [<Literal>]
    let private NeuterCode = 2

    [<Theory>]
    [<InlineData(0L, "рубль", "рубля", "рублей", MasculineCode, "ноль рублей")>]
    [<InlineData(1L, "рубль", Empty, "рублей", MasculineCode, "один рубль")>]
    [<InlineData(2L, "рубль", "рубля", "рублей", MasculineCode, "два рубля")>]
    [<InlineData(-3L, "рубль", "рубля", "рублей", MasculineCode, "минус три рубля")>]
    [<InlineData(4L, "рубль", "рубля", "рублей", MasculineCode, "четыре рубля")>]
    [<InlineData(-5L, Empty, "рубля", "рублей", MasculineCode, "минус пять рублей")>]
    [<InlineData(6L, "рубль", "рубля", "рублей", MasculineCode, "шесть рублей")>]
    [<InlineData(7L, "рубль", "рубля", "рублей", MasculineCode, "семь рублей")>]
    [<InlineData(8L, "рубль", "рубля", "рублей", MasculineCode, "восемь рублей")>]
    [<InlineData(9L, "рубль", "рубля", "рублей", MasculineCode, "девять рублей")>]
    [<InlineData(10L, "рубль", "рубля", "рублей", MasculineCode, "десять рублей")>]
    [<InlineData(11L, "рубль", "рубля", "рублей", MasculineCode, "одиннадцать рублей")>]
    [<InlineData(12L, "рубль", "рубля", "рублей", MasculineCode, "двенадцать рублей")>]
    [<InlineData(13L, "рубль", "рубля", "рублей", MasculineCode, "тринадцать рублей")>]
    [<InlineData(13L, "рубль", Empty, "рублей", MasculineCode, "тринадцать рублей")>]
    [<InlineData(14L, "рубль", "рубля", "рублей", MasculineCode, "четырнадцать рублей")>]
    [<InlineData(15L, "рубль", "рубля", "рублей", MasculineCode, "пятнадцать рублей")>]
    [<InlineData(16L, "рубль", "рубля", "рублей", MasculineCode, "шестнадцать рублей")>]
    [<InlineData(17L, "рубль", "рубля", "рублей", MasculineCode, "семнадцать рублей")>]
    [<InlineData(18L, "рубль", "рубля", "рублей", MasculineCode, "восемнадцать рублей")>]
    [<InlineData(19L, "рубль", "рубля", Empty, MasculineCode, "девятнадцать")>]
    [<InlineData(20L, "рубль", "рубля", "рублей", MasculineCode, "двадцать рублей")>]
    [<InlineData(40L, "рубль", "рубля", "рублей", MasculineCode, "сорок рублей")>]
    [<InlineData(-51L, "рубль", "рубля", "рублей", MasculineCode, "минус пятьдесят один рубль")>]
    [<InlineData(51L, Empty, "рубля", "рублей", MasculineCode, "пятьдесят один")>]
    [<InlineData(92L, "рубль", "рубля", "рублей", MasculineCode, "девяносто два рубля")>]
    [<InlineData(92L, "рубль", Empty, "рублей", MasculineCode, "девяносто два")>]
    [<InlineData(100L, "рубль", "рубля", "рублей", MasculineCode, "сто рублей")>]
    [<InlineData(100L, Empty, "рубля", Empty, MasculineCode, "сто")>]
    [<InlineData(101L, "рубль", "рубля", "рублей", MasculineCode, "сто один рубль")>]
    [<InlineData(-101L, Empty, Empty, Empty, MasculineCode, "минус сто один")>]
    [<InlineData(102L, "рубль", "рубля", "рублей", MasculineCode, "сто два рубля")>]
    [<InlineData(1000L, "рубль", "рубля", "рублей", MasculineCode, "одна тысяча рублей")>]
    [<InlineData(2001L, "рубль", "рубля", "рублей", MasculineCode, "две тысячи один рубль")>]
    [<InlineData(1000000L, "рубль", "рубля", "рублей", MasculineCode, "один миллион рублей")>]
    [<InlineData(198237812L, "рубль", "рубля", "рублей", MasculineCode, "сто девяносто восемь миллионов двести тридцать семь тысяч восемьсот двенадцать рублей")>]
    [<InlineData(0L, "миля", "мили", "миль", FeminineCode, "ноль миль")>]
    [<InlineData(-1L, "миля", "мили", "миль", FeminineCode, "минус одна миля")>]
    [<InlineData(2L, "миля", "мили", "миль", FeminineCode, "две мили")>]
    [<InlineData(3L, "миля", "мили", "миль", FeminineCode, "три мили")>]
    [<InlineData(4L, "миля", "мили", "миль", FeminineCode, "четыре мили")>]
    [<InlineData(5L, "миля", "мили", "миль", FeminineCode, "пять миль")>]
    [<InlineData(6L, "миля", "мили", "миль", FeminineCode, "шесть миль")>]
    [<InlineData(7L, "миля", "мили", "миль", FeminineCode, "семь миль")>]
    [<InlineData(8L, "миля", "мили", "миль", FeminineCode, "восемь миль")>]
    [<InlineData(9L, "миля", "мили", "миль", FeminineCode, "девять миль")>]
    [<InlineData(-10L, "миля", "мили", "миль", FeminineCode, "минус десять миль")>]
    [<InlineData(11L, "миля", "мили", "миль", FeminineCode, "одиннадцать миль")>]
    [<InlineData(12L, "миля", "мили", "миль", FeminineCode, "двенадцать миль")>]
    [<InlineData(13L, "миля", "мили", "миль", FeminineCode, "тринадцать миль")>]
    [<InlineData(13L, "миля", "мили", Empty, FeminineCode, "тринадцать")>]
    [<InlineData(14L, "миля", "мили", "миль", FeminineCode, "четырнадцать миль")>]
    [<InlineData(15L, "миля", "мили", "миль", FeminineCode, "пятнадцать миль")>]
    [<InlineData(16L, "миля", "мили", "миль", FeminineCode, "шестнадцать миль")>]
    [<InlineData(-17L, "миля", "мили", "миль", FeminineCode, "минус семнадцать миль")>]
    [<InlineData(18L, "миля", "мили", "миль", FeminineCode, "восемнадцать миль")>]
    [<InlineData(19L, "миля", "мили", "миль", FeminineCode, "девятнадцать миль")>]
    [<InlineData(20L, "миля", "мили", "миль", FeminineCode, "двадцать миль")>]
    [<InlineData(40L, "миля", "мили", "миль", FeminineCode, "сорок миль")>]
    [<InlineData(51L, "миля", "мили", "миль", FeminineCode, "пятьдесят одна миля")>]
    [<InlineData(51L, Empty, "мили", "миль", FeminineCode, "пятьдесят одна")>]
    [<InlineData(92L, "миля", "мили", "миль", FeminineCode, "девяносто две мили")>]
    [<InlineData(92L, "миля", Empty, "миль", FeminineCode, "девяносто две")>]
    [<InlineData(100L, "миля", "мили", "миль", FeminineCode, "сто миль")>]
    [<InlineData(100L, Empty, "мили", Empty, FeminineCode, "сто")>]
    [<InlineData(101L, "миля", "мили", "миль", FeminineCode, "сто одна миля")>]
    [<InlineData(101L, Empty, Empty, Empty, FeminineCode, "сто одна")>]
    [<InlineData(102L, "миля", "мили", "миль", FeminineCode, "сто две мили")>]
    [<InlineData(1000L, "миля", "мили", "миль", FeminineCode, "одна тысяча миль")>]
    [<InlineData(2001L, "миля", "мили", "миль", FeminineCode, "две тысячи одна миля")>]
    [<InlineData(1000000L, "миля", "мили", "миль", FeminineCode, "один миллион миль")>]
    [<InlineData(-198237812L, "миля", "мили", "миль", FeminineCode, "минус сто девяносто восемь миллионов двести тридцать семь тысяч восемьсот двенадцать миль")>]
    [<InlineData(0L, "очко", "очка", "очков", NeuterCode, "ноль очков")>]
    [<InlineData(1L, "очко", "очка", "очков", NeuterCode, "одно очко")>]
    [<InlineData(2L, "очко", "очка", "очков", NeuterCode, "два очка")>]
    [<InlineData(3L, "очко", "очка", "очков", NeuterCode, "три очка")>]
    [<InlineData(4L, "очко", "очка", "очков", NeuterCode, "четыре очка")>]
    [<InlineData(5L, "очко", "очка", "очков", NeuterCode, "пять очков")>]
    [<InlineData(6L, "очко", "очка", "очков", NeuterCode, "шесть очков")>]
    [<InlineData(7L, "очко", "очка", "очков", NeuterCode, "семь очков")>]
    [<InlineData(8L, "очко", "очка", "очков", NeuterCode, "восемь очков")>]
    [<InlineData(-9L, "очко", "очка", "очков", NeuterCode, "минус девять очков")>]
    [<InlineData(10L, "очко", "очка", "очков", NeuterCode, "десять очков")>]
    [<InlineData(11L, "очко", "очка", "очков", NeuterCode, "одиннадцать очков")>]
    [<InlineData(12L, "очко", "очка", "очков", NeuterCode, "двенадцать очков")>]
    [<InlineData(13L, "очко", "очка", "очков", NeuterCode, "тринадцать очков")>]
    [<InlineData(13L, "очко", "очка", Empty, NeuterCode, "тринадцать")>]
    [<InlineData(14L, "очко", "очка", "очков", NeuterCode, "четырнадцать очков")>]
    [<InlineData(15L, "очко", "очка", "очков", NeuterCode, "пятнадцать очков")>]
    [<InlineData(-16L, "очко", "очка", "очков", NeuterCode, "минус шестнадцать очков")>]
    [<InlineData(17L, "очко", "очка", "очков", NeuterCode, "семнадцать очков")>]
    [<InlineData(18L, "очко", "очка", "очков", NeuterCode, "восемнадцать очков")>]
    [<InlineData(19L, "очко", "очка", "очков", NeuterCode, "девятнадцать очков")>]
    [<InlineData(20L, "очко", "очка", "очков", NeuterCode, "двадцать очков")>]
    [<InlineData(-40L, "очко", "очка", "очков", NeuterCode, "минус сорок очков")>]
    [<InlineData(51L, "очко", "очка", "очков", NeuterCode, "пятьдесят одно очко")>]
    [<InlineData(51L, Empty, "очка", "очков", NeuterCode, "пятьдесят одно")>]
    [<InlineData(92L, "очко", "очка", "очков", NeuterCode, "девяносто два очка")>]
    [<InlineData(92L, "очко", Empty, "очков", NeuterCode, "девяносто два")>]
    [<InlineData(-100L, "очко", "очка", "очков", NeuterCode, "минус сто очков")>]
    [<InlineData(100L, Empty, "очка", Empty, NeuterCode, "сто")>]
    [<InlineData(101L, "очко", "очка", "очков", NeuterCode, "сто одно очко")>]
    [<InlineData(101L, Empty, Empty, Empty, NeuterCode, "сто одно")>]
    [<InlineData(102L, "очко", "очка", "очков", NeuterCode, "сто два очка")>]
    [<InlineData(1000L, "очко", "очка", "очков", NeuterCode, "одна тысяча очков")>]
    [<InlineData(2001L, "очко", "очка", "очков", NeuterCode, "две тысячи одно очко")>]
    [<InlineData(-1000000L, "очко", "очка", "очков", NeuterCode, "минус один миллион очков")>]
    [<InlineData(7915000101L, "очко", "очка", "очков", NeuterCode, "семь миллиардов девятьсот пятнадцать миллионов сто одно очко")>]
    let ``The result of toWordsInRussianWithDimension should be expected`` value nominative genitiveSingular genitivePlural gender expected =
        let russianWordGender =
            match gender with
            | FeminineCode -> Feminine
            | NeuterCode -> Neuter
            | _ -> Masculine

        let dimension = {
            Nominative = nominative;
            GenitiveSingular = genitiveSingular;
            GenitivePlural = genitivePlural;
            Gender = russianWordGender
        }

        toWordsInRussianWithDimension value dimension |> shouldBeEqual expected
