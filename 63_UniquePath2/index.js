/**
 * @param {number[][]} obstacleGrid
 * @return {number}
 */
const uniquePathsWithObstacles = (obstacleGrid) => {

    const cache = [...obstacleGrid].map((x) => x.map((y) => 0));

    obstacleGrid.forEach(
        (y, i) => {
            y.forEach((x, j) => {
                if (x === 1) {
                    cache[i][j] = 0;
                } else if (i === 0 && j === 0) {
                    cache[i][j] = 1;
                } else if (i === 0) {
                    cache[i][j] = cache[i][j - 1];
                } else if (j === 0) {
                    cache[i][j] = cache[i - 1][j];
                } else {
                    cache[i][j] = cache[i - 1][j] + cache[i][j - 1];
                }
            })
        }
    );

    return cache[cache.length - 1][cache[0].length - 1];

};