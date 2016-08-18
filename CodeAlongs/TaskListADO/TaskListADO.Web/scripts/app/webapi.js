$(document)
    .ready(function() {
        loadEmployees();
        loadWeather();
    });

function loadEmployeeById(id) {
    $.getJSON('/api/Employees/' + id)
        .done(function(data) {
            $('#employeeName').text(data.FirstName + " " + data.LastName);
            $('#grants tbody tr').remove();
            $.each(data.Grants,
                function(index, grant) {
                    $(createGrantRow(grant)).appendTo($('#grants tbody'));
                });

            $('#displayEmployeeModal').modal('show');
        });
}

function createGrantRow(grant) {
    return '<tr><td>' + grant.GrantName + '</td><td>' + grant.Amount + '</td></tr>';
}

function loadEmployees() {
    $.getJSON('/api/Employees/')
        .done(function(data) {
            $('#employees tbody tr').remove();
            $.each(data,
                function(index, employee) {
                    $(createRow(employee)).appendTo($('#employees tbody'));
                });
        });
}

function createRow(employee) {
    return '<tr><td><button onclick=\"loadEmployeeById(' + employee.EmpId + ');\">' +
        employee.EmpId +
        '</button></td><td>' +
        employee.FirstName +
        '</td><td>' +
        employee.LastName +
        '</td></tr>';
}

function loadWeather() {
    $.getJSON('http://api.openweathermap.org/data/2.5/weather?q=Akron,OH&APPID=')   //ADD YOUR API KEY HERE
        .done(function(data) {
            $('#weather tbody tr').remove();

            $(createWeatherRow(data)).appendTo($('#weather tbody'));
        });
}

function createWeatherRow(weather) {
    return '<tr><td>' + weather.name + '</td><td>' + ((9/5)*(weather.main.temp - 273) + 32) + '</td></tr>';
}