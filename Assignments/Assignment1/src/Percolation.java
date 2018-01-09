import java.lang.UnsupportedOperationException;
import java.lang.IllegalArgumentException;


import edu.princeton.cs.algs4.WeightedQuickUnionUF;

public class Percolation {
    
    public boolean[][] _grid;
    private int _dimensions;
    private int _numberOfOpenSites;
    private WeightedQuickUnionUF _uf;
    private int _topNode;
    private int _bottomNode;

    public Percolation(int n) {
        
        if(n <= 0) {
            throw new IllegalArgumentException("Dimensions cannot be less than or equal to 0");
        }
        
        _dimensions = n;
        _grid = new boolean[n][n];
        _percolates = false;
        _numberOfOpenSites = 0;
        
        uf = new WeightedQuickUnionUF(n * n + 1);
        _topNode = 0;
        _bottomNode = n * n + 2;
    }
    
    public void open(int row, int col) {
        if(inRange(row,col))
        {
            _grid[row][col] = true;
            
            //Connect Top
            if(row == 1) {
                uf.union(_grid[row,col],topNode);
            }

            //Connect Bottom
            if(row == _dimensions) {
                uf.union(_grid[row,col],bottomNode);
            }

            //Connect to open neighbors
            if (isOpen(row,col-1)) {
                uf.union(flatten(_grid[row][col]),flatten(_grid[row][col-1]))
            }

            if(isOpen(row,col+1)){
                uf.union(flatten(_grid[row][col]),flatten(_grid[row][col+1]))
            }

            if(isOpen(row-1,col)){
                uf.union(flatten(_grid[row][col]),flatten(_grid[row-1][col]))
            }

            if(isOpen(row+1,col)){
                uf.union(flatten(_grid[row][col]),flatten(_grid[row+1][col]))
            }

        } else {
            throw new IllegalArgumentException("Indices out of range, must be between 1 and "+_dimensions);
        }
    }
    
    public boolean isOpen(int row, int col) {
        if(inRange(row,col)) {
            return _grid[row][col];
        } else {
            throw new IllegalArgumentException("Indices out of range, must be between 1 and "+_dimensions);
        }
    }

    public boolean isFull(int row, int col) {
        if(inRange(row,col)) {
            return uf.connected(_grid[row][col],topNode)
        } else {
            throw new IllegalArgumentException("Indices out of range, must be between 1 and "+_dimensions);
        }
    }

    public int numberOfOpenSites() {
        return _numberOfOpenSites;
    }

    public boolean percolates(){
        return uf.connected(topNode,bottomNode);
    }

    public static void main(String[] args) {
        
        try{
            Percolation p = new Percolation(5);
            System.out.println(p.percolates());
            System.out.println(p.numberOfOpenSites());

            System.out.println(p.isOpen(1,2));
            p.open(1,2);
            System.out.println(p.isOpen(1,2));
            
            

        }catch(Exception e) {
            System.out.println(e.getMessage());
        }    
    }

    //##################################
    // PRIVATE HELPER METHODS
    //##################################

    /**
     * Check whether array is in range
     */

    public boolean inRange(int row, int col) {
        if(row < 1 || row > _dimensions) {
            return false;
        }

        if(col < 1 || col > _dimensions) {
            return false;
        }

        return true;
    }

    /**
     * Convert 2D Array to 1D
     */
    public int flatten(int row, int col) {
        return _dimensions * (row - 1) + col;
    }
}