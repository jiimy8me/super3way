//@version=5
strategy("Super 3-Way", overlay=true)


// superTrend1
Periods1 = input(title='ATR Period 1', defval=12)
sT1src = input(ohlc4, title='Source 1')
Multiplier1 = input.float(title='ATR Multiplier 1', step=0.1, defval=3.0)
changeATR1 = input(title='On = ta.atr(Preiods1) Off = ta.sma(ta.tr, Periods1)', defval=true)
atr1 = changeATR1 ? ta.atr(Periods1) : ta.sma(ta.tr, Periods1)
up1 = sT1src - (Multiplier1 * atr1)
up11 = nz(up1[1], up1)
up1 := close[1] > up11 ? math.max(up1, up11) : up1
dn1 = sT1src + (Multiplier1 * atr1)
dn11 = nz(dn1[1], dn1)
dn1 := close[1] < dn11 ? math.min(dn1, dn11) : dn1
trend1 = 1
trend1 := nz(trend1[1], trend1)
trend1 := trend1 == -1 and close > dn11 ? 1 : trend1 == 1 and close < up11 ? -1 : trend1
upPlot1 = plot(trend1 == 1 ? up1 : na, title='Up Trend 1', style=plot.style_linebr, linewidth=2, color=color.new(color.aqua, 0))
buySignal1 = trend1 == 1 and trend1[1] == -1
plotshape(buySignal1 ? up1 : na, title='Up Trend 1 Begins', location=location.absolute, style=shape.circle, size=size.tiny, color=color.new(color.aqua, 0))
dnPlot1 = plot(trend1 == 1 ? na : dn1, title='Down Trend 1', style=plot.style_linebr, linewidth=2, color=color.new(color.purple, 0))
sellSignal1 = trend1 == -1 and trend1[1] == 1
plotshape(sellSignal1 ? dn1 : na, title='Down Trend 1 Begins', location=location.absolute, style=shape.circle, size=size.tiny, color=color.new(color.purple, 0))
mPlot1 = plot(ohlc4, title='', style=plot.style_circles, linewidth=0)
longFillColor1 = color.aqua
shortFillColor1 = color.purple
fill(mPlot1, upPlot1, title='Up Trend 1 Highligter', color=color.new(longFillColor1, 90))
fill(mPlot1, dnPlot1, title='Down Trend 1 Highligter', color=color.new(shortFillColor1, 90))

// superTrend2
Periods2 = input(title='ATR Period 2', defval=11)
sT2src = input(ohlc4, title='Source 2')
Multiplier2 = input.float(title='ATR Multiplier 2', step=0.1, defval=2.0)
changeATR2 = input(title='On = ta.atr(Preiods2) Off = ta.sma(ta.tr, Periods2)', defval=true)
atr2 = changeATR2 ? ta.atr(Periods2) : ta.sma(ta.tr, Periods2)
up2 = sT2src - (Multiplier2 * atr2)
up12 = nz(up2[1], up2)
up2 := close[1] > up12 ? math.max(up2, up12) : up2
dn2 = sT2src + (Multiplier2 * atr2)
dn12 = nz(dn2[1], dn2)
dn2 := close[1] < dn12 ? math.min(dn2, dn12) : dn2
trend2 = 1
trend2 := nz(trend2[1], trend2)
trend2 := trend2 == -1 and close > dn12 ? 1 : trend2 == 1 and close < up12 ? -1 : trend2
upPlot2 = plot(trend2 == 1 ? up2 : na, title='Up Trend 2', style=plot.style_linebr, linewidth=2, color=color.new(color.aqua, 0))
buySignal2 = trend2 == 1 and trend2[1] == -1
plotshape(buySignal2 ? up2 : na, title='Up Trend 2 Begins', location=location.absolute, style=shape.circle, size=size.tiny, color=color.new(color.aqua, 0))
dnPlot2 = plot(trend2 == 1 ? na : dn2, title='Down Trend 2', style=plot.style_linebr, linewidth=2, color=color.new(color.purple, 0))
sellSignal2 = trend2 == -1 and trend2[1] == 1
plotshape(sellSignal2 ? dn2 : na, title='Down Trend 2 Begins', location=location.absolute, style=shape.circle, size=size.tiny, color=color.new(color.purple, 0))
mPlot2 = plot(ohlc4, title='', style=plot.style_circles, linewidth=0)
longFillColor2 = color.aqua
shortFillColor2 = color.purple
fill(mPlot2, upPlot2, title='Up Trend 2 Highligter', color=color.new(longFillColor2, 90))
fill(mPlot2, dnPlot2, title='Down Trend 2 Highligter', color=color.new(shortFillColor2, 90))

// superTrend3
Periods3 = input(title='ATR Period 3', defval=10)
sT3src = input(ohlc4, title='Source 3')
Multiplier3 = input.float(title='ATR Multiplier 3', step=0.1, defval=1.0)
changeATR3 = input(title='On = ta.atr(Preiods3) Off = ta.sma(ta.tr, Periods3)', defval=true)
atr3 = changeATR3 ? ta.atr(Periods3) : ta.sma(ta.tr, Periods3)
up3 = sT3src - (Multiplier3 * atr3)
up13 = nz(up3[1], up3)
up3 := close[1] > up13 ? math.max(up3, up13) : up3
dn3 = sT3src + (Multiplier3 * atr3)
dn13 = nz(dn3[1], dn3)
dn3 := close[1] < dn13 ? math.min(dn3, dn13) : dn3
trend3 = 1
trend3 := nz(trend3[1], trend3)
trend3 := trend3 == -1 and close > dn13 ? 1 : trend3 == 1 and close < up13 ? -1 : trend3
upPlot3 = plot(trend3 == 1 ? up3 : na, title='Up Trend 3', style=plot.style_linebr, linewidth=2, color=color.new(color.aqua, 0))
buySignal3 = trend3 == 1 and trend3[1] == -1
plotshape(buySignal3 ? up3 : na, title='Up Trend 3 Begins', location=location.absolute, style=shape.circle, size=size.tiny, color=color.new(color.aqua, 0))
dnPlot3 = plot(trend3 == 1 ? na : dn3, title='Down Trend 3', style=plot.style_linebr, linewidth=2, color=color.new(color.purple, 0))
sellSignal3 = trend3 == -1 and trend3[1] == 1
plotshape(sellSignal3 ? dn3 : na, title='Down Trend 3 Begins', location=location.absolute, style=shape.circle, size=size.tiny, color=color.new(color.purple, 0))
mPlot3 = plot(ohlc4, title='', style=plot.style_circles, linewidth=0)
longFillColor3 = color.aqua
shortFillColor3 = color.purple
fill(mPlot3, upPlot3, title='Up Trend 3 Highligter', color=color.new(longFillColor3, 90))
fill(mPlot3, dnPlot3, title='Down Trend 3 Highligter', color=color.new(shortFillColor3, 90))

// upTrend and dnTrend
upTrend = (trend3 == 1) and (trend2 == 1) and (trend1 == 1)
dnTrend = (trend3 == -1) and (trend2 == -1) and (trend1 == -1)

// trend broken
brTup = ((trend3 == -1) and (trend2 == -1)) or ((trend3 == -1) and (trend1 == -1)) or ((trend2 == -1) and (trend1 == -1))
brTdn = ((trend3 == 1) and (trend2 == 1)) or ((trend3 == 1) and (trend1 == 1)) or ((trend2 == 1) and (trend1 == 1))

// enter long if price closes above 3 superTrends
longRule = upTrend == true
// enter short if price closes below 3 superTrends
shortRule = dnTrend == true

// close long if 2 of 3 superTrends are down
longExit = brTup == true
// close short if 2 of 3 superTrends are up
shortExit = brTdn == true

// strategy rules
pctComm = 0.0006
aEntry = strategy.position_avg_price
pSize = strategy.position_size
oProfit = strategy.openprofit
pComm = (pctComm * aEntry)

if longRule
    strategy.entry("Long", strategy.long)
    if strategy.position_size > 0
        lEntry = (aEntry + pComm)
        pValue = ((aEntry * pSize) - ((aEntry * pSize) * pctComm))
        pProfit = (oProfit / pValue)
        longStop10p = lEntry * 1.075
        longStop7p5 = lEntry * 1.05
        longStop5p = lEntry * 1.025
        longStop2p5 = lEntry
        longStop = lEntry * 0.95
        if pProfit >= 0.1
            strategy.exit("Long", "Stop Loss", stop=longStop10p)
        else if pProfit >= 0.075
            strategy.exit("Long", "Stop Loss", stop=longStop7p5)
        else if pProfit >= 0.05
            strategy.exit("Long", "Stop Loss", stop=longStop5p)
        else if pProfit >= 0.025
            strategy.exit("Long", "Stop Loss", stop=longStop2p5)
        else
            strategy.exit("Long", "Stop Loss", stop=longStop)

if shortRule
    strategy.entry("Short", strategy.short)
    if strategy.position_size < 0
        sEntry = (aEntry - pComm)
        sValue = ((aEntry * pSize) + ((aEntry * pSize) * pctComm))
        sProfit = (oProfit / sValue)
        shortStop10p = sEntry * 0.925
        shortStop7p5 = sEntry * 0.95
        shortStop5p = sEntry * 0.975
        shortStop2p5 = sEntry
        shortStop = sEntry * 1.05
        if sProfit >= 0.1
            strategy.exit("Short", "Stop Loss", stop=shortStop10p)
        else if sProfit >= 0.075
            strategy.exit("Short", "Stop Loss", stop=shortStop7p5)
        else if sProfit >= 0.05
            strategy.exit("Short", "Stop Loss", stop=shortStop5p)
        else if sProfit >= 0.025
            strategy.exit("Short", "Stop Loss", stop=shortStop2p5)
        else
            strategy.exit("Short", "Stop Loss", stop=shortStop)

if longExit
    strategy.close("Long", "Long Exit")

if shortExit
    strategy.close("Short", "Short Exit")
