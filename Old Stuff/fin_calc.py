import sys
from graphics import *
def finance_calc_complete():
    
    principle = eval(input("Enter the amount you will deposit: "))
    if principle <= 0:
        print('Sorry that principle is to low')
        sys.exit()
    elif principle > 100000:
        print("That principle is too high! It must be under $100,000 ")
        sys.exit()
    interest = eval(input("Enter the annual % rate as a decimal: "))
    time = int((input("Enter the number of years: ")))
    period = int(input("Enter the number of periods the interest will accrue: "))
    payment = eval(input("Enter the amount you will pay each period: "))
    initial_principle = principle
    
    graph_width = 1200
    graph_height = 500
    dollar_per_pixel = 32/5000
    
    win = GraphWin("Financial Calculator", 1200, 500)
    number_to_convert = 0
    
    if principle > 0 and principle < 20000:
        for i in range(1,16):
            number_to_convert += 5000
            rounded_num = round(number_to_convert,1)
            string_number = str(number_to_convert)
            t1 = Text(Point(60, 495 - (32*i)), f'${string_number}')
            t1.setSize(8)
            t1.draw(win)
            l1 = Line(Point(60, 495-((32*i)+2)), Point(1200,495-((32*i)+2)))
            l1.draw(win)
    elif principle >= 20000 and principle < 60000:
        number_to_convert = 15000
        for i in range(1,16):
            number_to_convert += 5000
            rounded_num = round(number_to_convert,1)
            string_number = str(number_to_convert)
            t1 = Text(Point(60, 495 - (32*i)), f'${string_number}')
            t1.setSize(8)
            t1.draw(win)
    elif principle >= 60000 and principle < 100000:
        number_to_convert = 55000
        for i in range(1,16):
            number_to_convert += 5000
            rounded_num = round(number_to_convert,1)
            string_number = str(number_to_convert)
            t1 = Text(Point(60, 495 - (32*i)), f'${string_number}')
            t1.setSize(8)
            t1.draw(win)

    
    width_increase = (graph_width -(graph_width *.12)) /(time*period)
    xll1 = (graph_width * .12)
    height = principle * dollar_per_pixel
    bar = Rectangle(Point((graph_width * .12), 460), Point((graph_width * .12)+width_increase, 495-height))
    bar.setFill("green")
    bar.setWidth(2)
    bar.draw(win)
    t2 = Text((Point((xll1+ (width_increase *.5)), 480)), f'{1}')
    t2.setSize(8)
    t2.draw(win)

    for i in range(1,(time * period)):
        payment_counter = (payment * (i + 1))
        earnings = (principle * (interest / period))
        principle = earnings + principle + payment
        total_earnings = (principle - initial_principle) - payment_counter
        print("Period: ", f"{(i+1)}", "You now have:", f"${principle:1.2f}", "and have deposited a total of",
              f"${payment_counter + initial_principle:1.2f}", "and earned a total of", f"${total_earnings:1.2f}")
        xll = i * width_increase + (graph_width *.12)
        height = principle * dollar_per_pixel
        bar = Rectangle(Point(xll, 460), Point(xll+width_increase, 495-height))
        if (i) % 2 == 0:
            bar.setFill('blue')
        else:
            bar.setFill("red")
        bar.setWidth(2)
        bar.draw(win)
        t3 = Text((Point((xll+(width_increase * .5)), 480)), f'{i+1}')
        t3.setSize(8)
        t3.draw(win)
        
    
    input("Press enter to quit")
    win.close()
finance_calc_complete()