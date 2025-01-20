using Microsoft.Extensions.DependencyInjection;
using NatureOfCode;
using NatureOfCode.Exercice101;
using NatureOfCode.Exercice102;
using NatureOfCode.Exercice103;
using NatureOfCode.Exercice104;
using NatureOfCode.Exercice105;
using NatureOfCode.Exercice106;
using NatureOfCode.Exercice107;
using NatureOfCode.Exercice201;


var serviceProvider = new ServiceCollection()
    .AddSingleton<MonogameSample>()
    .AddSingleton<BouncingBallNoVectors>()
    .AddSingleton<BouncingBallVectors>()
    .AddSingleton<BouncingBallVectorsObject>()
    .AddSingleton<VectorSubtraction>()
    .AddSingleton<VectorMultiplication>()
    .AddSingleton<VectorMagnitude>()
    .AddSingleton<VectorNormalize>()
    .AddSingleton<Motion101>()
    .AddSingleton<NatureOfCode.Exercice201.Forces>()

    .BuildServiceProvider();

using var game = serviceProvider.GetRequiredService<BouncingBallNoVectors>();
game.Run();