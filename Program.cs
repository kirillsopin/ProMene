var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    string html = """
    <!DOCTYPE html>
    <html lang="uk">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Про мене</title>
        <link rel="stylesheet" href="/style.css">
    </head>
    <body>
        <main class="container">
            <section class="intro">
                <p class="eyebrow">МОЯ ОСОБИСТА СТОРІНКА</p>
                <h1>Привіт! Мене звати Кирило</h1>
                <p class="subtitle">Ласкаво прошу на мою сторінку</p>
            </section>

            <section class="card">
                <h2>Коротко про мене</h2>
                <p><strong>Ім'я:</strong> Кирило Сопін</p>
                <p><strong>Місто:</strong> Харків</p>
                <p><strong>Навчання:</strong> НТУ «ХПІ»</p>
                <p><strong>Напрям:</strong> Інформаційні технології</p>
                <p><strong>Хобі:</strong> Комп'ютерні ігри, баскетбол та хокей</p>
            </section>

            <section class="card interests">
                <h2>Мої інтереси</h2>
                <p>Мені подобається програмування, комп'ютери та сучасні технології.
                   Також у вільний час я люблю грати в комп'ютерні ігри та гуляти.</p>
            </section>

            <footer>© 2026 Моя сторінка</footer>
        </main>
    </body>
    </html>
    """;

    return Results.Content(html, "text/html; charset=utf-8");
});

app.MapGet("/style.css", () =>
{
    string css = """
    * {
        box-sizing: border-box;
    }

    body {
        margin: 0;
        min-height: 100vh;
        background: linear-gradient(135deg, #151522, #25213d);
        color: #f5f3ff;
        font-family: Arial, sans-serif;
    }

    .container {
        width: min(850px, calc(100% - 32px));
        margin: 0 auto;
        padding: 60px 0 30px;
    }

    .intro {
        text-align: center;
        margin-bottom: 35px;
    }

    .eyebrow {
        color: #a78bfa;
        font-size: 13px;
        font-weight: bold;
        letter-spacing: 3px;
    }

    h1 {
        margin: 15px 0;
        color: #c4b5fd;
        font-size: clamp(30px, 5vw, 46px);
    }

    .subtitle {
        color: #c4c1d4;
        font-size: 18px;
    }

    .card {
        margin: 20px 0;
        padding: 28px;
        background: rgba(255, 255, 255, 0.07);
        border: 1px solid rgba(196, 181, 253, 0.2);
        border-radius: 18px;
        box-shadow: 0 12px 35px rgba(0, 0, 0, 0.2);
    }

    h2 {
        margin-top: 0;
        color: #c4b5fd;
    }

    .card p {
        color: #e5e1f2;
        font-size: 17px;
        line-height: 1.7;
    }

    strong {
        color: #a78bfa;
    }

    footer {
        padding-top: 20px;
        color: #9691aa;
        text-align: center;
        font-size: 14px;
    }

    @media (max-width: 600px) {
        .container {
            padding-top: 35px;
        }

        .card {
            padding: 20px;
        }
    }
    """;

    return Results.Content(css, "text/css; charset=utf-8");
});

app.Run();
