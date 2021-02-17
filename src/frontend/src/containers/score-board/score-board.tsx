import React from 'react';
import Paper from '@material-ui/core/Paper';
import Table from '@material-ui/core/Table';
import TableBody from '@material-ui/core/TableBody';
import TableCell from '@material-ui/core/TableCell';
import TableContainer from '@material-ui/core/TableContainer';
import TableHead from '@material-ui/core/TableHead';
import TableRow from '@material-ui/core/TableRow';
import { useDispatch } from 'react-redux';
import { getAllPosts } from '../../store/action-creators';
import store from './../../store/store';

const ScoreBoard: React.FC = () => {
    // const posts: IPost[] = useSelector(
    //     (state: PostState) => state.posts, 
    //     (post) => post.length === 22
    // );    
    
    const posts: IPost[] = [];
    store.subscribe(() => {
        posts.length = 0;
        posts.push(...store.getState().posts);
        console.log(posts);
    });
    
    const dispatch = useDispatch();
    dispatch(getAllPosts());
    console.log(posts);

    return <div>
        <h1>Scoreboard</h1>
        <TableContainer component={Paper}>
            <Table aria-label="simple table">
                <TableHead>
                    <TableRow>
                        <TableCell>Message</TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {posts.map((post) => (
                        <TableRow key={post.id}>
                            <TableCell component="th" scope="row">
                                {post.message}
                            </TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>
        </TableContainer>
    </div>;
}

export default ScoreBoard;