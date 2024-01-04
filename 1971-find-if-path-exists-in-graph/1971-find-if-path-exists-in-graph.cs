public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = i;
            }

            foreach (var edge in edges)
            {
                var root1 = FindRoot(arr, edge[0]);
                var root2 = FindRoot(arr, edge[1]);

                if (root1 != root2)
                {
                    arr[root2] = arr[root1];
                }
            }

            var sourceRoot = FindRoot(arr, source);
            var destRoot = FindRoot(arr, destination);

            return sourceRoot == destRoot;
        }

        private int FindRoot(int[] arr, int v)
        {
            while (v != arr[v])
            {
                v = arr[v];
            }
            return v;
        }
}