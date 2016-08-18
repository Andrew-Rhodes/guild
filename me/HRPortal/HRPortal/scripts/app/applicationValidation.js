$(document)
    .ready(function() {
        $('appForm')
            .validate({
                rules: {
                    FirstName: {
                        required: true
                    },
                    LastName: {
                        required: true,
                    },
                    StreetAddress: {
                        required: true
                    },
                    City: {
                        required: true,
                    },
                    State: {
                        required: true
                    },
                    Company: {
                        required: true
                    },
                    Position: {
                        required: true
                    },
                    OkTerms: {
                        required: true
                    },
                    ApplicationNumber: {
                        required: true
                    },
                    TheDate: {
                        required: true
                    }
                },
                messages: {
                    FirstName: "Enter your first name",
                    LastName: "Enter your last name",
                    StreetAddress: "Enter your street address",
                    City: "Enter your city",
                    State: "Enter the state",
                    Company: "Enter the company",
                    Position: "Enter the position you are applying for",
                    OkTerms: "Is all the information correct",
                    ApplicationNumber: "Enter the application Number",
                    TheDate: "Enter your starting date"

                }
            });
    });