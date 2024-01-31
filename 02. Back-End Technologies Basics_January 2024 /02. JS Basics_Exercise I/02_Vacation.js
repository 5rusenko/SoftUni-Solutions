function solve(numOfPeople, typeOfGroup, dayOfWeek) {

    let totalPrice = 0;

    if (typeOfGroup === 'Students') {
        if (dayOfWeek === 'Friday') {
            totalPrice = numOfPeople * 8.45;
        } else if (dayOfWeek === 'Saturday') {
            totalPrice = numOfPeople * 9.80;
        } else if (dayOfWeek === 'Sunday') {
            totalPrice = numOfPeople * 10.46;
        }

        if (numOfPeople >= 30) {
            totalPrice = totalPrice * 0.85;
        }

    } else if (typeOfGroup === 'Business') {
        if (dayOfWeek === 'Friday') {
            totalPrice = numOfPeople * 10.90;
        } else if (dayOfWeek === 'Saturday') {
            totalPrice = numOfPeople * 15.60;
        } else if (dayOfWeek === 'Sunday') {
            totalPrice = numOfPeople * 16;
        }

        if (numOfPeople>=100){
            const pricePerNight = totalPrice/numOfPeople;
            totalPrice = pricePerNight * (numOfPeople-10);
        }

    } else if (typeOfGroup === 'Regular') {
        if (dayOfWeek === 'Friday') {
            totalPrice = numOfPeople * 15;
        } else if (dayOfWeek === 'Saturday') {
            totalPrice = numOfPeople * 20;
        } else if (dayOfWeek === 'Sunday') {
            totalPrice = numOfPeople * 22.50;
        }

        if (numOfPeople>=10 && numOfPeople <=20) {
            totalPrice = totalPrice *0.95;
        }
    }

    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}
solve (30, "Students", "Sunday");