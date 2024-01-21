function Vacation(ppl1, type1, day1) {

    let ppl = Number(ppl1);
    let type = String(type1);
    let day = String(day1);
    let total = 0;

    if (day == 'Friday'){

        if (type == 'Students'){

            if (ppl >= 30){

                total = (ppl * 8.45) * 0.85;

            }
            else{

                total = ppl * 8.45;

            }

        }

        else if (type == 'Business'){

            if (ppl >= 100){

                total = (ppl * 10.9) - 109;

            }

            else{

                total = ppl * 10.9;

            }

        }

        else if (type == 'Regular'){

            if (ppl >= 10 && ppl <= 20){

                total = (ppl * 15) * 0.95;

            }

            else {

                total = ppl * 15;

            }

        }

    }

    else if (day == 'Saturday'){

        if (type == 'Students'){

            if (ppl >= 30){

                total = (ppl * 9.8) * 0.85;

            }
            else{

                total = ppl * 9.80;

            }

        }

        else if (type == 'Business'){

            if (ppl >= 100){

                total = (ppl * 15.6) - 156;

            }

            else{

                total = ppl * 15.6;

            }

        }

        else if (type == 'Regular'){

            if (ppl >= 10 && ppl <= 20){

                total = (ppl * 20) * 0.95;

            }

            else {

                total = ppl * 20;

            }
            
        }

    }

    else if (day == 'Sunday'){
        
        if (type == 'Students'){

            if (ppl >= 30){

                total = (ppl * 10.46) * 0.85;

            }
            else{

                total = ppl * 10.46;

            }

        }

        else if (type == 'Business'){

            if (ppl >= 100){

                total = (ppl * 16) - 160;

            }

            else{

                total = ppl * 16;

            }

        }

        else if (type == 'Regular'){

            if (ppl >= 10 && ppl <= 20){

                total = (ppl * 22.5) * 0.95;

            }

            else {

                total = ppl * 22.5;

            }
            
        }

    }

    total = total.toFixed(2);

    console.log(`Total price: ${total}`);
}

Vacation(30,
    "Students",
    "Sunday"
    );
Vacation(40,
    "Regular",
    "Saturday"
    );